# ISTM 420 - TKG Burgers

<div id=introduction>
  For our final group project in ISTM 420, we were tasked with creating the front-end of a web application for a restaurant using the following technologies we had learned over the course of the semester:
  <br><br>
  <ul>
    <li>ASP.NET Core MVC</li>
    <li>HTML5</li>
    <li>CSS3</li>
    <li>jQuery</li>
  </ul>
  
  The web application did not have to contain a fully functional back-end or database system, as the primary exercise of the project was for groups to demonstrate their ability to create an aesthetically-pleasing and proper user interface for the application. The requirements for the project were as follows:
  <br>
  <ol>
    <li>Design a "master page" for the entire website.</li>
    <li>Use external CSS to provide appropriate styling for each web page.</li>
    <li>Implement a "shopping cart" process for customers.</li>
    <li>Make use of at least three (3) jQuery effects or animations.</li>
  </ol>
  
  In addition, the web application needed to include the following web pages:
  <br>
  <ul>
    <li>Home Page</li>
    <li>About Us</li>
    <li>Product/Service Catalog or Menu</li>
    <li>Shopping Cart</li>
    <li>Customer Account/Checkout</li>
  </ul>

  Our group, consisting of myself (Tanner Croom) alongside classmates Katie Hand and Garrett Jones, created a web-application for the fictional restaurant TKG Burgers, located in Bryan, Texas and serving customers across the Bryan-College Station area. TKG Burgers is known for their famous burgers, chicken sandwiches, and chicken tenders, as well as their low prices to entice the significant population of college students that reside in the area.
  
  Our web application for TKG Burgers contains a fully-functioning front-end user interface, as well as an included SQL Server back-end system to help manage the shopping cart and ordering systems. Our full project also contains a written report documenting our code.
  
</div>
  
<hr>
  
<div id=instructions>
  <h3>How to Run This Application</h3>
  
  <p>First, <a href="https://github.com/tannercroom/istm420-tkgburgers/releases">download the latest release of this project</a>, then extract all files to a single location. In the <i>Team2</i> folder, open the file <i>Team2.sln</i> in a recent version of Microsoft Visual Studio.</p>
	
  This web application was created in Microsoft Visual Studio 2019. Any recent version of Microsoft Visual Studio can be used to open and run this application. However, in order for the application to successfully build and have the shopping cart and ordering systems function properly, the following packages must be installed through the NuGet Package Manager (found in the menu bar under Tools > NuGet Package Manager > Manage NuGet Packages for Solution...):
  
  <ul>
    <li>Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore v3.1.22</li>
	  <li>Microsoft.AspNetCore.Identity.EntityFrameworkCore v3.1.22</li>
	  <li>Microsoft.AspNetCore.Identity.UI v3.1.22</li>
	  <li>Microsoft.EntityFrameworkCore.SqlServer v3.1.22</li>
	  <li>Microsoft.EntityFrameworkCore.Tools v3.1.22</li>
  </ul>
  
  Once installed, run the following in the Package Manager Console (found in the menu bar under Tools > NuGet Package Manager > Package Manager Console):
	
  <code>Update-Database Product -context ProductContext</code>
  
  Once this is completed, the user can run the application by clicking the dropdown arrow next to "Start" then selecting "420ProjectTeam2". The application will run in a separate window of the user's default web browser.
</div>
