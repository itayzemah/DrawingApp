--------------------------------------------------------
--  File created - יום ראשון-ספטמבר-06-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table DOCUMENT_MARKERS
--------------------------------------------------------

  CREATE TABLE "ITAY"."DOCUMENT_MARKERS" 
   (	"MARKERID" VARCHAR2(50 BYTE), 
	"DOCID" VARCHAR2(50 BYTE), 
	"USERID" VARCHAR2(50 BYTE), 
	"MARKERTYPE" VARCHAR2(20 BYTE), 
	"MARKERLOCATION" VARCHAR2(200 BYTE), 
	"FORE_COLOR" VARCHAR2(60 BYTE), 
	"BACK_COLOR" VARCHAR2(60 BYTE), 
	"ISACTIVE" VARCHAR2(1 BYTE) DEFAULT 1
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table DOCUMENTS
--------------------------------------------------------

  CREATE TABLE "ITAY"."DOCUMENTS" 
   (	"DOCID" VARCHAR2(40 BYTE), 
	"OWNER" VARCHAR2(50 BYTE), 
	"IMAGEURL" VARCHAR2(500 BYTE), 
	"DOCUMENTNAME" VARCHAR2(50 BYTE), 
	"ISACTIVE" VARCHAR2(1 BYTE) DEFAULT 1
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table SHARED_DOCUMENTS
--------------------------------------------------------

  CREATE TABLE "ITAY"."SHARED_DOCUMENTS" 
   (	"DOCID" VARCHAR2(50 BYTE), 
	"USERID" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USERS
--------------------------------------------------------

  CREATE TABLE "ITAY"."USERS" 
   (	"USERID" VARCHAR2(50 BYTE), 
	"USERNAME" VARCHAR2(50 BYTE), 
	"USEREMAIL" VARCHAR2(60 BYTE), 
	"ISACTIVE" VARCHAR2(1 BYTE) DEFAULT 1
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;

   COMMENT ON COLUMN "ITAY"."USERS"."USERID" IS 'Guid';
   COMMENT ON COLUMN "ITAY"."USERS"."ISACTIVE" IS 'remove';
REM INSERTING into ITAY.DOCUMENT_MARKERS
SET DEFINE OFF;
Insert into ITAY.DOCUMENT_MARKERS (MARKERID,DOCID,USERID,MARKERTYPE,MARKERLOCATION,FORE_COLOR,BACK_COLOR,ISACTIVE) values ('m_id','test','test','C','1','1','1','1');
Insert into ITAY.DOCUMENT_MARKERS (MARKERID,DOCID,USERID,MARKERTYPE,MARKERLOCATION,FORE_COLOR,BACK_COLOR,ISACTIVE) values ('m_id2','test','test','C','1','1','1','1');
REM INSERTING into ITAY.DOCUMENTS
SET DEFINE OFF;
Insert into ITAY.DOCUMENTS (DOCID,OWNER,IMAGEURL,DOCUMENTNAME,ISACTIVE) values ('524f60d0-57a0-4286-a878-5445dd0b364b','4eba670f-31d8-4237-b418-db360a6ad2a5','url','name','1');
Insert into ITAY.DOCUMENTS (DOCID,OWNER,IMAGEURL,DOCUMENTNAME,ISACTIVE) values ('df690829-dd0b-44c8-bb91-1f280a4a1efb','4eba670f-31d8-4237-b418-db360a6ad2a5','url','4eba670f-31d8-4237-b418-db360a6ad2a5','0');
Insert into ITAY.DOCUMENTS (DOCID,OWNER,IMAGEURL,DOCUMENTNAME,ISACTIVE) values ('test','test','URL','Name1','1');
REM INSERTING into ITAY.SHARED_DOCUMENTS
SET DEFINE OFF;
REM INSERTING into ITAY.USERS
SET DEFINE OFF;
Insert into ITAY.USERS (USERID,USERNAME,USEREMAIL,ISACTIVE) values ('4eba670f-31d8-4237-b418-db360a6ad2a5','Itay','itay@gmail.com','1');
Insert into ITAY.USERS (USERID,USERNAME,USEREMAIL,ISACTIVE) values ('test','test','test','1');
Insert into ITAY.USERS (USERID,USERNAME,USEREMAIL,ISACTIVE) values ('653d3ca1-c87e-4635-b3ea-44ab48b6eab2','i@z.com','Itay','0');
Insert into ITAY.USERS (USERID,USERNAME,USEREMAIL,ISACTIVE) values ('d26c2724-e03f-4dab-a726-1774d9796619','Test','mail@test.com','1');
--------------------------------------------------------
--  DDL for Index DOCUMENTMARKERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ITAY"."DOCUMENTMARKERS_PK" ON "ITAY"."DOCUMENT_MARKERS" ("MARKERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index DOCUMENTS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ITAY"."DOCUMENTS_PK" ON "ITAY"."DOCUMENTS" ("DOCID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SHARED_DOCUMENTS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ITAY"."SHARED_DOCUMENTS_PK" ON "ITAY"."SHARED_DOCUMENTS" ("DOCID", "USERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ITAY"."USERS_PK" ON "ITAY"."USERS" ("USERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Procedure ADD_DOCUMENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."ADD_DOCUMENT" 
(
  p_DOC_ID IN documents.docid%TYPE 
, p_OWNER_ID IN documents.owner%TYPE
, p_URL IN documents.imageurl%TYPE
, p_DOCUMENT_NAME IN documents.documentname%TYPE 
, p_IS_ACTIVE IN documents.isactive%TYPE
) AS 
BEGIN
       INSERT INTO documents (
        docid,
        owner,
        imageurl,
        documentname,
        isactive
    ) VALUES (
        p_DOC_ID,
       p_OWNER_ID,
       p_URL,
       p_DOCUMENT_NAME,
       p_IS_ACTIVE
    );
END ADD_DOCUMENT;

/
--------------------------------------------------------
--  DDL for Procedure ADD_MARKER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."ADD_MARKER" 
(
  P_MARKER_ID IN document_markers.markerid%TYPE
, P_DOC_ID IN document_markers.dOcid%TYPE 
, P_USER_ID IN document_markers.userid%TYPE 
, P_MARKER_TYPE IN document_markers.markertype%TYPE 
, P_MARKER_LOCATION IN document_markers.markerlocation%TYPE 
, P_FORE_COLOR IN document_markers.fore_color%TYPE 
, P_BACK_COLOR IN document_markers.back_color%TYPE 
) AS 
BEGIN
         INSERT INTO document_markers (
        markerid,
        dOcid,
        userid,
        markertype,
                markerlocation,
        fore_color,
back_color,
isactive
    ) VALUES (
 P_MARKER_ID 
, P_DOC_ID 
, P_USER_ID 
, P_MARKER_TYPE 
, P_MARKER_LOCATION 
, P_FORE_COLOR 
, P_BACK_COLOR 
,1
    );
END ADD_MARKER;

/
--------------------------------------------------------
--  DDL for Procedure ADD_MARKER_TO_DOCUMENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."ADD_MARKER_TO_DOCUMENT" 
(
P_DOC_ID IN documents.docid%TYPE
, P_MARKER_ID IN document_markers.MARKERID%TYPE
, P_USER_ID IN document_markers.userid%TYPE
, P_MARKER_TYPE IN document_markers.markertype %TYPE
, P_MARKER_LOCATION IN document_markers.markerlocation%TYPE
, P_FORE_COLOR IN document_markers.fore_color%TYPE
, P_BACK_COLOR IN document_markers.back_color%TYPE
) AS 
BEGIN
  insert into document_markers (
  DOCID, MARKERID , USERID , MARKERTYPE , MARKERLOCATION   , FORE_COLOR , BACK_COLOR,ISACTIVE)
VALUES(P_DOC_ID,P_MARKER_ID,P_USER_ID,P_MARKER_TYPE,P_MARKER_LOCATION,P_FORE_COLOR,P_BACK_COLOR,'1')
;
END Add_marker_to_document;

/
--------------------------------------------------------
--  DDL for Procedure ADD_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."ADD_USER" (
 p_user_id IN users.userid%TYPE 
, p_user_email IN users.useremail%TYPE 
, p_user_name IN users.username%TYPE
) AS 
BEGIN
       INSERT INTO users (
        userid,
        useremail,
        username
    ) VALUES (
        p_user_id,
       p_user_email,
       p_user_name
    );
END;

/
--------------------------------------------------------
--  DDL for Procedure GET_ALL_DOCS_OF
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."GET_ALL_DOCS_OF" 
(
  P_OWNER_ID IN documents.owner%TYPE 
, ALL_DOCS OUT SYS_REFCURSOR 
) AS 
BEGIN
    open ALL_DOCS for
  select DOCID , OWNER , IMAGEURL , DOCUMENTNAME , ISACTIVE  
  from documents
WHERE owner = P_OWNER_ID AND isactive ='1';
END GET_ALL_DOCS_OF;

/
--------------------------------------------------------
--  DDL for Procedure GET_ALL_MARKERS_FOR_DOC
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."GET_ALL_MARKERS_FOR_DOC" 
(
  DOC_ID IN document_markers.docid%TYPE 
, MARKERS_RV OUT SYS_REFCURSOR 
) AS 
BEGIN
  open markers_rv for
    select *
  from document_markers
WHERE docid = DOC_ID;
END GET_ALL_MARKERS_FOR_DOC;

/
--------------------------------------------------------
--  DDL for Procedure LOGIN
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."LOGIN" 
(
  EMAIL IN users.useremail%type 
, USER_RV OUT SYS_REFCURSOR 
) AS 
BEGIN
  open user_rv for
  select USERID ,
USERNAME ,
USEREMAIL ,
ISACTIVE  from users
  WHERE users.useremail = email ;
END LOGIN;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_DOCUMENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."REMOVE_DOCUMENT" 
(P_DOC_ID IN documents.docid%TYPE, 
P_retval OUT SYS_REFCURSOR )
 AS 
BEGIN
   UPDATE documents SET isactive=0  WHERE docid = P_DOC_ID;
    OPEN P_RETVAL FOR
    SELECT *
    FROM documents 
    WHERE docid = P_DOC_ID;
END REMOVE_DOCUMENT;

/
--------------------------------------------------------
--  DDL for Procedure REMOVE_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "ITAY"."REMOVE_USER" 
(P_USER_ID IN users.USERID%TYPE, P_retval OUT SYS_REFCURSOR )
IS
BEGIN
    UPDATE USERS SET isactive=0  WHERE USERID = P_USER_ID;
    OPEN P_RETVAL FOR
    SELECT *
    FROM USERS 
    WHERE USERID = P_USER_ID;
END Remove_User;

/
--------------------------------------------------------
--  Constraints for Table DOCUMENT_MARKERS
--------------------------------------------------------

  ALTER TABLE "ITAY"."DOCUMENT_MARKERS" MODIFY ("MARKERID" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."DOCUMENT_MARKERS" ADD CONSTRAINT "DOCUMENTMARKERS_PK" PRIMARY KEY ("MARKERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "ITAY"."DOCUMENT_MARKERS" MODIFY ("ISACTIVE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "ITAY"."DOCUMENTS" MODIFY ("DOCID" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."DOCUMENTS" MODIFY ("OWNER" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."DOCUMENTS" ADD CONSTRAINT "DOCUMENTS_PK" PRIMARY KEY ("DOCID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "ITAY"."DOCUMENTS" MODIFY ("ISACTIVE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table SHARED_DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "ITAY"."SHARED_DOCUMENTS" MODIFY ("DOCID" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."SHARED_DOCUMENTS" MODIFY ("USERID" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."SHARED_DOCUMENTS" ADD CONSTRAINT "SHARED_DOCUMENTS_PK" PRIMARY KEY ("DOCID", "USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "ITAY"."USERS" MODIFY ("USERID" NOT NULL ENABLE);
  ALTER TABLE "ITAY"."USERS" ADD CONSTRAINT "USERS_PK" PRIMARY KEY ("USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "ITAY"."USERS" MODIFY ("ISACTIVE" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table DOCUMENT_MARKERS
--------------------------------------------------------

  ALTER TABLE "ITAY"."DOCUMENT_MARKERS" ADD CONSTRAINT "DOCUMENTMARKERS_FK1" FOREIGN KEY ("USERID")
	  REFERENCES "ITAY"."USERS" ("USERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "ITAY"."DOCUMENTS" ADD CONSTRAINT "DOCUMENTS_FK1" FOREIGN KEY ("OWNER")
	  REFERENCES "ITAY"."USERS" ("USERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table SHARED_DOCUMENTS
--------------------------------------------------------

  ALTER TABLE "ITAY"."SHARED_DOCUMENTS" ADD CONSTRAINT "SHARED_DOCUMENTS_FK1" FOREIGN KEY ("DOCID")
	  REFERENCES "ITAY"."DOCUMENTS" ("DOCID") ENABLE;
  ALTER TABLE "ITAY"."SHARED_DOCUMENTS" ADD CONSTRAINT "SHARED_DOCUMENTS_FK2" FOREIGN KEY ("USERID")
	  REFERENCES "ITAY"."USERS" ("USERID") ENABLE;
