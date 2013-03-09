##BrickPile is a lightweight CMS built on RavenDB and ASP.NET MVC 4.

## Requirements
### Brace yourself, BrickPile makes the following demands:
* ASP.NET MVC 4
* [RavenDB](http://ravendb.net/)

**And that's about it.** A slight bit of knowledge about ASP.NET MVC development is also required.
##Installing and Updating
###Getting Installed
Installing BrickPile is simply the act of writing a single PowerShell command inside the package manager console.

  PM> Install-Package BrickPile -Pre

**And that's basically it.** Of course you need an empty ASP.NET MVC 4 web application.

##Configuration
As default BrickPile will use the RavenDB server on http://localhost:8080 but this can easily be configured to use an other port or RavenDB embedded with the following example.

	<connectionStrings>
		<add name="RavenDB" connectionString="DataDir = ~\App_Data\Data" />
	</connectionStrings>

**Note:** To run BrickPile with RavenDB server you need to [download](http://ravendb.net/download) it and execute `[RavenDBdir]\Server\Raven.Server.exe`. For more configuration options see [RavenDB documentation](http://ravendb.net/documentation).

### Assets configuration
In order to use Assets you have to change two things.
In `Global.asax`, add:
`HostingEnvironment.RegisterVirtualPathProvider(new NativeVirtualPathProvider());`

And then make sure that your `web.config` has the correct PhysicalPath and that the directory exist:

        <appSettings>
             <add key="PhysicalPath" value="C:\temp\static\" />
        </appSettings>

**Note:** The PhysicalPath can also be relative to the site root like this `~/App_Data/`

## Setup
When the configuration is done just hit `F5` inside Visual Studio, this will hopefully bring up the setup screen.
Fill the form with the correct information and hit "Let's do this" and your done.
 
