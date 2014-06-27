<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginSuccessful.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel='stylesheet' type="text/css" href='bootstrap.css'/>
<link rel='stylesheet' type="text/css" href='bootstrap-theme.css'/>

    <title></title>

    
</head>
<body>
    
    <form id="form1" runat="server">
    
    <ul class="nav nav-tabs">
  <li class="active"><a href="#">Profile</a></li>
  <li><a href="search.aspx">Search</a></li>
  <li><a href="upload.aspx">Upload Content</a></li>
<li><a href="leaderboard.aspx">LeaderBoard</a></li>
</ul>




<div id="Div1" style="position:relative;width:100%;
height:300px;overflow: scroll;">
     <table class="table table-hover"  >
        <tr >
                              
            <td> UserId</td>            
            <td>ItemId</td>  
            <td>Rating</td>                      
       <td>DateRated</td>                      
       
        </tr>


        <%=getWhileLoopData()%>

    </table>
  

  </div>

  <hr />

  <div id="DivFree" style="position:relative;width:100%;height:50px;">
  
  </div>


  <div id="Div2" style="position:relative;width:100%;
height:300px;overflow: scroll;">
  <h3>Theses are recommended topics for you</h3>

     <table class="table table-hover"  >
        <tr >
                              
            <td> Itemname</td>            
            <td>Itemrate</td>  
            <td>ItemAuthor</td>                      
            <td>Itemcategory </td>                    
            <td>Itemtopic </td>                    
            <td>TimeRequired </td>                    
            <td>Link </td>                    
                             
                       
      
        </tr>


        <%=recommendeddata()%>

    </table>
  

  </div>


  
    </form>


</body>
</html>
