# finjs-web-api

Web API for live-data feed

https://www.infragistics.com/products/ignite-ui-angular/angular/components/grid/live-data


# Usage

- There are helper methods for data generation and random update of records
- Two models FinancialData and PercentChange

In order to use the API, pass a details parameters for 'length' and 'live'
- length - number - how many records to be fetched by the service (e.g. 10000)

```
https://localhost:44378/webapi/details?length=5
```
- live - true - live updating of records (true/false)

```
https://localhost:44378/webapi/details?length=2&&live=true
```

- default state will return 45 predefined records

```
https://localhost:44378/webapi/
```