// coded along with Jani
// import packages
using AzureCosmosDemo;
using Microsoft.Azure.Cosmos;

// initializing connection properties
string url = "https://fullstackbootcamp.documents.azure.com:443/";
string conct = "ggin9VzmcjzctgLyh9NGAUKHuG4EGbZnSroyUeptddNkDygZKSGOMJ2FJJ2nRR0B4vyFC5tSoY7vACDbTIeIZg==";
string databaseName = < name of the database>;
string containerName = < which container you want to interact with>;
string partitionKey = < key >;

// Initializes client
using CosmosClient client = new(url, conct);

// initialize the database to get access
var response = await client.CreateDatabaseIfNotExistsAsync(databaseName);
Console.WriteLine();
Database database = client.GetDatabase(databaseName);
Console.WriteLine();

// work with the container
Container container = await database.CreateContainerIfNotExistsAsync(containerName, partitionKey);
Console.WriteLine($"Opened container: {container.Id}");


// create data to be stored
CustomerData customer = new()
{
    id = "my-first-customer",
    CustomerName = "My First Customer Inc.",
    EmailAddress = "info@firstcustomer.com",
    PhoneNumber = "123 456 789"
};

// Initializes customerdata into object and puts it into Cosmos Db container.
CustomerData createdItem = await container.CreateItemAsync(customer);
Console.WriteLine($"Created item: {createdItem.id}");