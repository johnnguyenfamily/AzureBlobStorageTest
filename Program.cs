using Azure.Storage.Blobs;

Console.WriteLine("START testing...");

var blobStorageConnnectionString = "StorageAccount>Security + networking>Access keys>key1>Connectionstring";
var blobStorageContainerName = "fileupload2";

var container = new BlobContainerClient(blobStorageConnnectionString, blobStorageContainerName);

// Add a test.txt file
Console.WriteLine("Add test.txt file");
var blob = container.GetBlobClient("test.txt");
var stream = File.OpenRead("C:\\Temp\\test.txt");
await blob.UploadAsync(stream);

// Delete the file
Console.WriteLine("Delete test.txt file");
blob.DeleteIfExists();

// Undelete the file
Console.WriteLine("Undelete test.txt file");
blob.Undelete();

Console.WriteLine("END testing.");