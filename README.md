# Azure Kubernetes Service

## 1: Creating Container Instance on Azure using the Docker Image
1. Open Cloud Shell on Azure Portal.
2. Create a resource group in the portal or the CLI for the AKS resource.    
    `az group create --name rg-aks-001 --location eastus`
3. Create a Container Registry in the Azure Portal.     
    `az acr create --resource-group rg-aks-001 --name #ACRName --sku Basic --admin-enabled`
4. Clone this Git Repo on the Azure Cloud Shell.    
    `git clone https://github.com/wiservarun/work-with-aks`
5. Navigate to the root folder.    
    `cd work-with-aks/SampleAKSApp`
6. Build the Docker Image for the web app and push it to the ACR.    
    `az acr build --registry #ACRName --image sampleaksapp:1.0 .`
7. Create an Azure Container Instance in the portal using the image built in the previosu step. 
    Search Container Instance in the Add Resource. Select networking type as Public with a unique DNS label. This will create an new Public IP for the container instance. 
    
    <img src="Images/1.1.PNG" width="400" height="400"/>
8. Access the FQDN URL created for your container instance in format.</br>
    `http://<DNS Label>.<Region>.azurecontainer.io`
    
## 2: Getting Started with AKS  
1. Create your AKS cluster on the Azure Portal in the same resource group. 
    </br>A. Choose below configurations for lesser cost or configuration of your choice. 
       </br><img src="Images/1.2.PNG" width="400" height="300"/>
    </br>B. Please make sure to enable Virtual Nodes under the Node Pools tab. 
       </br> <img src="Images/1.3.PNG" width="400" height="180"/>
    </br>C. Use Authentication method as "System-assigned managed Identity" in the Authentication tab.
    </br>D. Select the Container Registry created earlier in the Integrations tab.
 
       
