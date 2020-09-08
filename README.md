# Energy tariff comparison API

## What is it?
A Service to retrieve the tariffs comparison between two fictional energy providers via HTTP GET method

## How to run it?
Since it is an Asp.Net application you will need to have a version of VisualStudio installed on a Widows OS.
After that will be just a matter of building, and starting the application using IIS Express. 

## How to run its tests?
Is possible to run the tests also on VisualStudio, if you can't see the "Test Explorer" right away you can add it by clicking into Test -> Windows -> Test Explorer (or using the short-cut Ctrl+E, T).

## How to send a request?
When the application starts your default browser should open with the locahost domain and the port in which the application is currently running, for example, let's say in my case its ``http://localhost:58129``, then the route to get the results should be ``http://localhost:58129/api/tariffComparison?consumption=[energy consumption in kWh/year]``
