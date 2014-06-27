<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link rel='stylesheet' type="text/css" href='bootstrap.css'/>
<link rel='stylesheet' type="text/css" href='bootstrap-theme.css'/>

    <title></title>
</head>
<body>

<ul class="nav nav-tabs">
  <li ><a href="loginSuccessful.aspx">Home</a></li>
  <li class="active"><a href="search.aspx?flag=0">Search</a></li>
  <li><a href="upload.aspx">Upload Content</a></li>
</ul>

    <form id="form1" runat="server">
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

<hr/>
<div class="row">
    <div class="input-group col-md-3 col-md-offset-4">
      <span class="input-group-addon">How much time do you have-</span>
      <input type="text" id="hours" runat="server" class="form-control"/>
      <span class="input-group-addon">Hrs</span>
    </div>
    <div class="col-sm-offset-6 col-sm-10">

      <asp:Button ID="Button2" runat="server" onclick="Button2_Click" CssClass='btn btn-default' Text="Search" />
            
    </div>
    
    <hr/>
</div>



<div class="panel panel-default col-xs-12">
  <div class="panel-heading">Search results</div>
  <div class="panel-body">
    <p>We think that the following content would be best for you to study given your time and subject constraints:</p>
  </div>

  <table id="searchResults"  class="table">
    <tr>
    <td>ItemName</td>
    <td>Link</td>
    <td>Last Rated On</td>
    <td>Rating</td>
    <td>Author</td>
    <td>Rate</td>
    </tr>
    <%=showhere() %>
  </table>
</div>



    </form>
</body>
</html>
