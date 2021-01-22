# Animal Shelter API

### Independent project for Epicodus building out an API, 1.22.2021

#### By Bess Campbell

## Description

You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a project, take this opportunity to showcase your versatility for the project manager.

Building an API
For your final C#/.NET code review, you’ll build one of the three APIs below:

--> * Animal Shelter: Create an API for a local animal shelter. The API will list the available cats and dogs at the shelter.
* Local Business Lookup: Create an API for a local business lookup. The API will list restaurants and shops in town.
* Parks Lookup: Create an API for state and national parks. The API will list state and national parks.

You have the freedom to build out your APIs as you wish. At the very least, your API should include the following:

* Full CRUD functionality.
* Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
* Complete documentation of API endpoints and the further exploration you did.

## Prerequisites

### Software Requirements

• A browser like [Chrome](https://www.google.com/chrome/)

• A code editor like [VSCode](https://code.visualstudio.com/download)

• With [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) installed

• [MySQL](https://dev.mysql.com/downloads/file/?id=484914) **Instructions for setup below**

• [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391) **Instructions for setup below**

• [Postman](https://www.postman.com/downloads/)(optional)

#### MySQL & MySQL Workbench Setup instructions

* Download the [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914). Click the 'No thanks, just start my download' link.
* Follow along with the installer until you reach the Configuration page. Then select the following options:
  * Use Legacy Password Encryption.
  * Set password to **epicodus** or to your own personlized password.
  * Click Finish.

* Open the terminal and enter the command `echo 'export PATH="/usr/local/mysql//bin:$PATH"'>>~/.bash_profile`
* Type `source ~/.bash_profile` in the terminal to verify that MySQL was installed.
* Enter `mysql -uroot -pepicodus` or `mysql -uroot -p{your_password}` in the terminal to verify the installation. You will know it's installed when you gain access to the `mysql>` command line.
* Download the [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391) file using the 'No thanks, just start my download' link.
* Install MySQL Workbench in the Applications folder.
* Open MySQL Workbench and select the `Local instance 3306` server. You will need to enter the password **epicodus** (or the password you set). 

#### Setup and Use (cloning)

 * Open your terminal and ensure you are within the directory you'd like the file to be created in.
 * Enter the following command `$ git clone https://github.com/besscampbell/AnimalShelter.git`
 * Once cloned, use the `$ cd AnimalShelter.Solution/APIAnimalShelter` command to navigate to the project directory.
 * Enter `$ dotnet restore`

#### Import database with Entity Framework Core
* Now enter `$ dotnet ef database update` to create database in MySQL.
* To run the console application, enter `$ dotnet run`
* Your command line will open a server (likely `http://localhost:5000/`). Navigate to this URL in your browser to view the project.

#### Import Database with MySQL Workbench
* In the top toolbar of MySQL Workbench, click on `Server -> Data Import`.
* Select option for `Import from Self-Contained File`.
* Set the `Default Target Schema` or create a new schema.
* Select Schema Objects you wish to import.
* Ensure the option `Dump Structure and Data` is selected (located near the bottom).
* Click `Start Import`

#### Launch the API
* Navigate to `$ cd AnimalShelter.Solution/APIAnimalShelter`
* Run the `$ dotnet run` command to access CRUD capabilities of the API in Postman or in the browser using Swagger.
* When you are finished accessing the API  you can clost your live server by pressing `control` and `C`.

## API Documentation

Search through the endpoints of the Animal Shelter API using Postman or in your browser using your local host. It will most likely look something like this: `http://localhost:5000/`

### Accessing the API using Postman

![Postman](./ReadMeAssets/Postman.png)

#### GET --> api/cats and api/cats/3 
 With your live server running open the Postman app and type `http://localhost:5000/api/cats` or `http://localhost:5000/api/dogs` into the the URI line and choose `GET` from the CRUD functionalities drop down box and hit send. A response will appear in the body below. This will return a list of all the cats or dogs. 
 To get specific information about an animal append the CatId or the DogId to the end of the URL like this:  `http://localhost:5000/api/cats/3` and hit send. This will return the Cat with the CatId = 3.

#### PUT --> api/cats/3
 To update information about an existing cat or dog you will need to submit all of the informations for or cat/dog through the `Body` tab three to the right of the `Params` tab under the URL. Select `raw` and then `JSON` from the dropdowns and then enter the updated information along with all other info:
 ``` 
  {
        "catId": 3,
        "name": "Agatha Christie",
        "age": 13,
        "sex": "Female",
        "breed": "Persian",
        "coloring": "Grey",
        "dateAvailable": "2021-01-22T11:26:17.744366",
        "personality": "Agatha is a senior cat looking for her furrever lap. She loves snuggles and head pets"
    }
```
 Select `PUT` from the CRUD drop down list and press send. To double check that the cat/dog was updated do send a `GET` request.




## Technologies Used

_This application required use of the following programs/languages/libraries to create:_
* _GitBash_
* _Visual Studio Code_
* _GitHub_
* _C# v 7.3_
* _.NET Core v 2.2_
* _ASP.NET Core MVC_
* _Bootstrap_
* _CSS_
* _cshtml_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_
* _Postman_
* _Swagger_
* _Swashbuckler_

## Known Bugs

No known bugs.

## Support and contact details

Feel free to contact <bess.k.campbell@gmail.com>

## License

_MIT_ Copyright (c) 2020 *_Bess Campbell_*