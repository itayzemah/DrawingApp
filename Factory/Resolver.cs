﻿using ItayDrowingApp.AppContracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Factory
{
    public class Resolver :IResolver
    {
        IServiceCollection _serviceCollection;
        IServiceProvider _serviceProvider;
        Dictionary<Policy, Func<Type, Type, IServiceCollection>> _policyFunc;
        public Resolver(string path, IServiceCollection serviceCollection)
        {
            _policyFunc = InitPolicy();

            _serviceCollection = serviceCollection;
            LoadLibraries(path);
        }
        public Resolver(string path)
        {

            _policyFunc = InitPolicy();

            _serviceCollection = new ServiceCollection();
            _serviceCollection = InitServiceCollection(path);

            _serviceProvider = _serviceCollection.BuildServiceProvider();
            //Load Libraries and Interfaces
            //Here we are going to add some 

        }

        private Dictionary<Policy, Func<Type, Type, IServiceCollection>> InitPolicy()
        {
            var retval = new Dictionary<Policy, Func<Type, Type, IServiceCollection>>();
            retval.Add(Policy.Singleton, (interfaceType, type) => _serviceCollection.AddSingleton(interfaceType, type));
            retval.Add(Policy.Transient, (interfaceType, type) => _serviceCollection.AddTransient(interfaceType, type));
            retval.Add(Policy.Scoped, (interfaceType, type) => _serviceCollection.AddScoped(interfaceType, type));

            return retval;
        }
        private IServiceCollection InitServiceCollection(string dllpath)
        {
            IServiceCollection retval = new ServiceCollection();
            var files = Directory.GetFiles(dllpath, "*.dll");
            foreach (var file in files)
            {
                var assembly = Assembly.LoadFrom(file);
                foreach (var type in assembly.GetTypes())
                {
                    var attributes = type.GetCustomAttributes<RegisterAttribute>();
                    foreach (var register in attributes)
                    {
                        _serviceCollection = _policyFunc[register.Policy](register.InterfaceType, type);
                    }

                }
            }
            return retval;
        }
        public void LoadLibraries(string path)
        {
            _serviceCollection = InitServiceCollection(path);
        }
        public IEnumerable<IT> ResolveAll<IT>()
        {
            var retval = _serviceProvider.GetServices<IT>();
            return retval;
        }
        public IT Resolve<IT>()
        {

            IT retval = _serviceProvider.GetService<IT>();
            return retval;
        }

        public object Resolve(Type type)
        {
            var retval = _serviceProvider.GetService(type);
            return retval;
        }

        public IEnumerable<object> ResolveAll(Type type)
        {
            var retval = _serviceProvider.GetServices(type);
            return retval;
        }
    }
}
