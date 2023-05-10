import os
from azure.storage.blob import BlobServiceClient

# not needed in the demonstration done BlobClient, ContainerClient

#Dont forget to install the azure tool using the pip command.

# Set the connection string and container name
connect_str = "Key access"
container_name = 'name'

# Blob service client initliazed
blob_service_client = BlobServiceClient.from_connection_string(connect_str)

# Container initialized
container_client = blob_service_client.get_container_client(container_name)

# Set the local file path or can enter a message
local_file_path = 'File\path'

# Blob will set the name based on the filename
blob_name = os.path.basename(local_file_path)

# Create a BlobClient object
blob_client = container_client.get_blob_client(blob_name)

# Upload the file to Azure Blob Storage
with open(local_file_path, 'rb') as data:
    blob_client.upload_blob(data, overwrite=True)
    