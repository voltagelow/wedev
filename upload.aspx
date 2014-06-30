<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="upload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel='stylesheet' type="text/css" href='bootstrap.css'/>
<link rel='stylesheet' type="text/css" href='bootstrap-theme.css'/>
</head>
<body>
    <form id="form1" runat="server">
    

  
 <div class="col-md-6 col-md-offset-1">

  <div 

 >
 
 <h3  id="head"  runat="server"></h3>
 
 </div>



   <div class="form-group">
    <label for="exampleInputPassword1">ItemName</label>
    <input type="text" class="form-control" id="ItemName" runat="server" placeholder="ItemName">

  </div>
 

    <div>
<table align="center">
<tr>
<td>
Select Category:
</td>
<td>
<asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true"
onselectedindexchanged="ddlCategory_SelectedIndexChanged"></asp:DropDownList>
</td>
</tr>
<tr>

<tr style="height:20px;"></tr>

<td>
Select Topic:
</td>
<td>
<asp:DropDownList ID="ddlTopic" runat="server" AutoPostBack="true"
onselectedindexchanged="ddlTopic_SelectedIndexChanged"></asp:DropDownList>
</td>
</tr>
</table>
</div>




  <div class="form-group">
    <label for="exampleInputPassword1">TimeRequired</label>
    <input type="text" class="form-control" id="ItemTime" runat="server" placeholder="Time Required"/>
  </div>

  <div class="form-group">
    <label for="exampleInputFile">File input</label>
   

      <asp:FileUpload ID="uploadfile" runat="server" />
  
  </div>

    <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Upload" />
  


</div>



    
   
    </form>
</body>
</html>
