<%@ Page Language="C#" AutoEventWireup="true" CodeFile="leaderboard.aspx.cs" Inherits="leaderboard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel='stylesheet' type="text/css" href='bootstrap.css'/>
    <link rel='stylesheet' type="text/css" href='bootstrap-theme.css'/>

</head>
<body>
    <form id="form1" runat="server">
    
    <div id="Div1" style="position:relative;width:100%;
height:300px;overflow: scroll;">
     <table class="table table-hover"  >
        <tr >
                              
            <td> ItemAuthor</td>            
            <td>ItemName</td>  
            <td>TotalRating</td>                      
                        
       
        </tr>


        <%=getLeaderBoard()%>

    </table>
  

  </div>
    
    </form>
</body>
</html>
