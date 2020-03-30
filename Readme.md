# Lambda Postgres

This repository contains the result of introducing myself to AWS Lambda.

## What it does & Technology

A simple .Net Core Lambda app which takes an input from SQS and writes it to a Postgres-DB.

## Usage

Add a .connection file on root level with the following content:
```
Host=...;Database=...;Username=...;Password=...
```
Make sure the file is included in the build.