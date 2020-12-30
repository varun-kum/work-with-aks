# work-with-aks

1: Running containers on Azure Container Instances
1. Open Cloud Shell on Azure Portal.
2. Create a resource group in the portal or the CLI for the AKS resource.
    az group create --name rg-aks-001 --location eastus
3. Create a Container Registry in the Azure Portal. 
    az acr create --resource-group rg-aks-001 --name #ACRName --sku Basic --admin-enabled
4. Clone this Git Repo on the Azure Cloud Shell
    https://github.com/wiservarun/work-with-aks
5. Navigate to the root folder.
    cd work-with-aks/SampleAKSApp
6. Build the Docker Image for the web app and push it to the ACR
    az acr build --registry #ACRName --image sampleaksapp:1.0 .
7. Create an Azure Container Instance in the portal using the image built. 
    Select networking type as Public with a unique DNS label. Thsi will create an new Public IP for the container instance. 
8. Access the URL.
