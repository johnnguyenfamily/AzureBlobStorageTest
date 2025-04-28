The purpose of this repository is to create a sample C# project to test the Azure blob storage. We'll demo how to add a file, delete a file and undelete it.

Step 1: Create an Azure storage account
Step 2: Create a blob container from the storage account
Step 3: Create a sample C# Console app using VS2022
Step 4: Manage Azure.Storage.Blobs NuGet package
	- AzureBlobStorageTest (Right mouse click) > Manage NuGet Packages... 
	- Add the nuget.org Package source if not already exists
		Name: nuget.org
		Source: https://api.nuget.org/v3/index.json
	- Install Azure.Storage.Blobs package
Step 5: Write the C# logic (Program.cs)
Step 6: Run the console app to test adding, deleting and undeleting file from storage account