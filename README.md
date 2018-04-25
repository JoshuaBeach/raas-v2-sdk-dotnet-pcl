# Getting started

With this RESTful API you can integrate a global reward or incentive program into your app or platform. If you have any questions or if you'd like to receive your own credentials, please contact us at devsupport@tangocard.com.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (Raas.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Raas library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

### 3. Add reference of the library project

In order to use the Raas library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Raas.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```Raas.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Raas-CSharp&workspaceName=Raas&projectName=Raas.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| platformName | Platform Name (Provided by Tango Card) |
| platformKey | Platform Key (Provided by Tango Card) |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string platformName = "QAPlatform2"; // Platform Name (Provided by Tango Card)
string platformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj"; // Platform Key (Provided by Tango Card)

RaasClient client = new RaasClient(platformName, platformKey);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [StatusController](#status_controller)
* [AccountsController](#accounts_controller)
* [OrdersController](#orders_controller)
* [FundController](#fund_controller)
* [ExchangeRatesController](#exchange_rates_controller)
* [CustomersController](#customers_controller)
* [CatalogController](#catalog_controller)

## <a name="status_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.StatusController") StatusController

### Get singleton instance

The singleton instance of the ``` StatusController ``` class can be accessed from the API Client.

```csharp
StatusController status = client.Status;
```

### <a name="get_system_status"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.StatusController.GetSystemStatus") GetSystemStatus

> *Tags:*  ``` Skips Authentication ``` 

> Retrieves system status


```csharp
Task<Raas.Models.SystemStatusResponseModel> GetSystemStatus()
```

#### Example Usage

```csharp

Raas.Models.SystemStatusResponseModel result = await status.GetSystemStatus();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="accounts_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.AccountsController") AccountsController

### Get singleton instance

The singleton instance of the ``` AccountsController ``` class can be accessed from the API Client.

```csharp
AccountsController accounts = client.Accounts;
```

### <a name="get_accounts_by_customer"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.AccountsController.GetAccountsByCustomer") GetAccountsByCustomer

> Retrieves a list of accounts for a given customer


```csharp
Task<List<Raas.Models.AccountSummaryModel>> GetAccountsByCustomer(string customerIdentifier)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerIdentifier |  ``` Required ```  | Customer Identifier |


#### Example Usage

```csharp
string customerIdentifier = "customerIdentifier";

List<Raas.Models.AccountSummaryModel> result = await accounts.GetAccountsByCustomer(customerIdentifier);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="create_account"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.AccountsController.CreateAccount") CreateAccount

> Creates an account under a given customer


```csharp
Task<Raas.Models.AccountModel> CreateAccount(string customerIdentifier, Raas.Models.CreateAccountRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerIdentifier |  ``` Required ```  | Customer Identifier |
| body |  ``` Required ```  | Request Body |


#### Example Usage

```csharp
string customerIdentifier = "customerIdentifier";
var body = new Raas.Models.CreateAccountRequestModel();

Raas.Models.AccountModel result = await accounts.CreateAccount(customerIdentifier, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_all_accounts"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.AccountsController.GetAllAccounts") GetAllAccounts

> Retrieves all accounts under the platform


```csharp
Task<List<Raas.Models.AccountModel>> GetAllAccounts()
```

#### Example Usage

```csharp

List<Raas.Models.AccountModel> result = await accounts.GetAllAccounts();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_account"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.AccountsController.GetAccount") GetAccount

> Retrieves a single account


```csharp
Task<Raas.Models.AccountModel> GetAccount(string accountIdentifier)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountIdentifier |  ``` Required ```  | Account Identifier |


#### Example Usage

```csharp
string accountIdentifier = "accountIdentifier";

Raas.Models.AccountModel result = await accounts.GetAccount(accountIdentifier);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="orders_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.OrdersController") OrdersController

### Get singleton instance

The singleton instance of the ``` OrdersController ``` class can be accessed from the API Client.

```csharp
OrdersController orders = client.Orders;
```

### <a name="get_order"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.OrdersController.GetOrder") GetOrder

> Retrieves a single order


```csharp
Task<Raas.Models.OrderModel> GetOrder(string referenceOrderID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| referenceOrderID |  ``` Required ```  | Reference Order ID |


#### Example Usage

```csharp
string referenceOrderID = "referenceOrderID";

Raas.Models.OrderModel result = await orders.GetOrder(referenceOrderID);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="create_resend_order"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.OrdersController.CreateResendOrder") CreateResendOrder

> Resends an order


```csharp
Task<Raas.Models.ResendOrderResponseModel> CreateResendOrder(string referenceOrderID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| referenceOrderID |  ``` Required ```  | The order's reference order id |


#### Example Usage

```csharp
string referenceOrderID = "referenceOrderID";

Raas.Models.ResendOrderResponseModel result = await orders.CreateResendOrder(referenceOrderID);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_orders"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.OrdersController.GetOrders") GetOrders

> Retrieves a list of orders under a platform


```csharp
Task<Raas.Models.GetOrdersResponseModel> GetOrders(Raas.Models.GetOrdersInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountIdentifier |  ``` Optional ```  | Account identifier |
| customerIdentifier |  ``` Optional ```  | Customer identifier |
| externalRefID |  ``` Optional ```  | External reference id |
| startDate |  ``` Optional ```  | The start date |
| endDate |  ``` Optional ```  | The end date |
| elementsPerBlock |  ``` Optional ```  | The number of elements per page |
| page |  ``` Optional ```  | The page number to return |


#### Example Usage

```csharp
GetOrdersInput collect = new GetOrdersInput();

string accountIdentifier = "accountIdentifier";
collect.AccountIdentifier = accountIdentifier;

string customerIdentifier = "customerIdentifier";
collect.CustomerIdentifier = customerIdentifier;

string externalRefID = "externalRefID";
collect.ExternalRefID = externalRefID;

DateTime? startDate = DateTime.Now();
collect.StartDate = startDate;

DateTime? endDate = DateTime.Now();
collect.EndDate = endDate;

int? elementsPerBlock = 231;
collect.ElementsPerBlock = elementsPerBlock;

int? page = 231;
collect.Page = page;


Raas.Models.GetOrdersResponseModel result = await orders.GetOrders(collect);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.OrdersController.CreateOrder") CreateOrder

> Places an order


```csharp
Task<Raas.Models.OrderModel> CreateOrder(Raas.Models.CreateOrderRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | A CreateOrderRequest object |


#### Example Usage

```csharp
var body = new Raas.Models.CreateOrderRequestModel();

Raas.Models.OrderModel result = await orders.CreateOrder(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="fund_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.FundController") FundController

### Get singleton instance

The singleton instance of the ``` FundController ``` class can be accessed from the API Client.

```csharp
FundController fund = client.Fund;
```

### <a name="create_unregister_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.CreateUnregisterCreditCard") CreateUnregisterCreditCard

> Unregister a credit card


```csharp
Task<Raas.Models.UnregisterCreditCardResponseModel> CreateUnregisterCreditCard(Raas.Models.UnregisterCreditCardRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Raas.Models.UnregisterCreditCardRequestModel();

Raas.Models.UnregisterCreditCardResponseModel result = await fund.CreateUnregisterCreditCard(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_deposit"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.GetDeposit") GetDeposit

> Get details for a specific credit card deposit


```csharp
Task<Raas.Models.GetDepositResponseModel> GetDeposit(string depositId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| depositId |  ``` Required ```  | The reference deposit id |


#### Example Usage

```csharp
string depositId = "depositId";

Raas.Models.GetDepositResponseModel result = await fund.GetDeposit(depositId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="create_deposit"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.CreateDeposit") CreateDeposit

> Funds an account via credit card


```csharp
Task<Raas.Models.DepositResponseModel> CreateDeposit(Raas.Models.DepositRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Raas.Models.DepositRequestModel();

Raas.Models.DepositResponseModel result = await fund.CreateDeposit(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_credit_cards"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.GetCreditCards") GetCreditCards

> Retrieves all credit cards registered on the platform


```csharp
Task<List<Raas.Models.CreditCardModel>> GetCreditCards()
```

#### Example Usage

```csharp

List<Raas.Models.CreditCardModel> result = await fund.GetCreditCards();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.GetCreditCard") GetCreditCard

> Retrieves details for a single credit card


```csharp
Task<Raas.Models.CreditCardModel> GetCreditCard(string token)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| token |  ``` Required ```  | Credit Card Token |


#### Example Usage

```csharp
string token = "token";

Raas.Models.CreditCardModel result = await fund.GetCreditCard(token);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="create_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.FundController.CreateCreditCard") CreateCreditCard

> Registers a new credit card


```csharp
Task<Raas.Models.CreditCardModel> CreateCreditCard(Raas.Models.CreateCreditCardRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | A CreateCreditCardRequest object |


#### Example Usage

```csharp
var body = new Raas.Models.CreateCreditCardRequestModel();

Raas.Models.CreditCardModel result = await fund.CreateCreditCard(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="exchange_rates_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.ExchangeRatesController") ExchangeRatesController

### Get singleton instance

The singleton instance of the ``` ExchangeRatesController ``` class can be accessed from the API Client.

```csharp
ExchangeRatesController exchangeRates = client.ExchangeRates;
```

### <a name="get_exchange_rates"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.ExchangeRatesController.GetExchangeRates") GetExchangeRates

> Retrieve current exchange rates


```csharp
Task<Raas.Models.ExchangeRateResponseModel> GetExchangeRates()
```

#### Example Usage

```csharp

Raas.Models.ExchangeRateResponseModel result = await exchangeRates.GetExchangeRates();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="customers_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.CustomersController") CustomersController

### Get singleton instance

The singleton instance of the ``` CustomersController ``` class can be accessed from the API Client.

```csharp
CustomersController customers = client.Customers;
```

### <a name="create_customer"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.CustomersController.CreateCustomer") CreateCustomer

> Creates a new customer


```csharp
Task<Raas.Models.CustomerModel> CreateCustomer(Raas.Models.CreateCustomerRequestModel body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request Body |


#### Example Usage

```csharp
var body = new Raas.Models.CreateCustomerRequestModel();

Raas.Models.CustomerModel result = await customers.CreateCustomer(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_all_customers"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.CustomersController.GetAllCustomers") GetAllCustomers

> Retrieves all customers under the platform


```csharp
Task<List<Raas.Models.CustomerModel>> GetAllCustomers()
```

#### Example Usage

```csharp

List<Raas.Models.CustomerModel> result = await customers.GetAllCustomers();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


### <a name="get_customer"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.CustomersController.GetCustomer") GetCustomer

> Retrieves a single customer


```csharp
Task<Raas.Models.CustomerModel> GetCustomer(string customerIdentifier)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerIdentifier |  ``` Required ```  | Customer Identifier |


#### Example Usage

```csharp
string customerIdentifier = "customerIdentifier";

Raas.Models.CustomerModel result = await customers.GetCustomer(customerIdentifier);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)

## <a name="catalog_controller"></a>![Class: ](https://apidocs.io/img/class.png "TangoCard.Raas.Controllers.CatalogController") CatalogController

### Get singleton instance

The singleton instance of the ``` CatalogController ``` class can be accessed from the API Client.

```csharp
CatalogController catalog = client.Catalog;
```

### <a name="get_catalog"></a>![Method: ](https://apidocs.io/img/method.png "TangoCard.Raas.Controllers.CatalogController.GetCatalog") GetCatalog

> Retrieves a platform's catalog


```csharp
Task<Raas.Models.CatalogModel> GetCatalog()
```

#### Example Usage

```csharp

Raas.Models.CatalogModel result = await catalog.GetCatalog();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | API Error |


[Back to List of Controllers](#list_of_controllers)



