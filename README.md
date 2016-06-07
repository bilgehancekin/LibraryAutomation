# Library Automation Application

This application provides storing, listing and searching operations for books on the library system. Moreover, Admin can save the borrowing and recieving book information.



## Getting Started

To run the project properly there ar some instructions listed below:

1-)Open KütüphaneWeb project and locate Web.config file find definition of connection string
...
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=TARDIS;Initial Catalog=kutuphane;Integrated Security=True" providerName="System.Data.SqlClient" />
 </connectionStrings>
...

2-)Replace DataSource value with your own data server name for example "127.0.0.1" and Catalog value can be replace with the your database name. 

3-)After runnig the KutuphaneWeb project, database will be generated automatically.

4-)Open Kütüphane project and locate App.config file find definition of connection string 

...
  <connectionStrings>
    <add name="Kutuphane.Properties.Settings.LocalDbConnectionString" 
         connectionString="Data Source=TARDIS;Initial Catalog=kutuphane;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
 ...

5-)Replace DataSource and Catalog values with the specified values in the KütüphaneWeb project's Web.config file.

6-)You are ready to go.

## Built With

* Visual Studio 2013 or later versions.

## Authors

* **Bilgehan Çekin** - *Initial work* - [bilgehancekin](https://github.com/bilgehancekin)
