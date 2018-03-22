# Creighton_Model_Backend_Capstone
NSS Cohort 22 Backend Capstone Project

## This application consists of:

*   Sample pages using ASP.NET Core MVC and Identity framework
*   [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## Overview

This version of # Fertility Tracking App implements the Identity framework, and extends the base User object with the `ApplicationUser` model. 

Look in the `DbInitializer` class to see the product types that are seeded for you.

This project was built in Microsoft [Visual Studio Code](https://code.visualstudio.com/).

## Run & Deploy

1. Clone this repo
1. `cd` to new directory
1. Run following commands
    
    ```
    dotnet restore
    dotnet ef database udpdate
    dotnet run
    ```
