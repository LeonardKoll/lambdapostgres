# Lambda Postgres

This repository contains the result of introducing myself to AWS Lambda.

## What it does & Technology

A simple .Net Core Lambda app which takes an input from SQS and writes it to a Postgres-DB.

## Usage

Add a .connection file on root level with the following content.
Make sure the file is included in the build.
```
Host=...;Database=...;Username=...;Password=...
```

Setup a Postgres-DB with the following table:
```
-- Table: public.calcs

-- DROP TABLE public.calcs;

CREATE TABLE public.calcs
(
    term text COLLATE pg_catalog."default",
    result double precision,
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 )
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.calcs
    OWNER to postgres;
```