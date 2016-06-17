<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DailyDeals.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
    

     <!-- Carousel
    ================================================== -->
    <br />
    <br />
    <br />
    <br />
    
    
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
      <!-- Indicators -->
      <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner" role="listbox">
        <div class="item active">
          <img class="first-slide cour" src="Images/cour1.png" alt="First slide" />
          
        </div>
        <div class="item">
          <img class="second-slide cour" src="Images/cour2.png" alt="Second slide" />
          
        </div>
        <div class="item">
          <img class="third-slide cour" src="Images/cour3.png" alt="Third slide" />
          
        </div>
      </div>
      <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div><!-- /.carousel -->


    <!-- Marketing messaging and featurettes
    ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->
    
    <div class="container marketing">

      <!-- Three columns of text below the carousel -->
      <div class="row" runat="server" id="itemsDisplay">
        
      </div><!-- /.row -->


      <!-- START THE FEATURETTES -->

      <hr class="featurette-divider"/>

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">Getting Started is Easy. <span class="text-muted">Start by Creating an account.</span></h2>
          <p class="lead">Fill out a few of your details and create a new account for your self.</p>
        </div>
        <div class="col-md-5">
          <img class="featurette-image img-responsive center-block" src="Images/login.png" alt="Generic placeholder image"/>
        </div>
      </div>

      <hr class="featurette-divider"/>

      <div class="row featurette">
        <div class="col-md-7 col-md-push-5">
          <h2 class="featurette-heading">Oh yeah, it's very simple. <span class="text-muted">Now Browse through the Collection.</span></h2>
          <p class="lead">Search from a library of many deals available and choose the best one you like. New deals are added everyday as the older deals expire. So make sure to check back daily.</p>
        </div>
        <div class="col-md-5 col-md-pull-7">
          <img class="featurette-image img-responsive center-block" src="Images/suits.jpg" alt="Generic placeholder image"/>
        </div>
      </div>

      <hr class="featurette-divider"/>

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">And lastly, get it delivered. <span class="text-muted">Pay when you recieve the good.</span></h2>
          <p class="lead">If the deal you selected gets the appropriate number of interested candidates, the deal gets activated. Enjoy your favorite stuff at the cheapest price possible.</p>
        </div>
        <div class="col-md-5">
          <img class="featurette-image img-responsive center-block" src="Images/deliver.png" alt="Generic placeholder image"/>
        </div>
      </div>

      

      <!-- /END THE FEATURETTES -->


     

    </div><!-- /.container -->
</asp:Content> 
