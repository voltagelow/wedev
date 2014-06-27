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
    
 
  
 
   <div class="form-group">
    <label for="exampleInputPassword1">ItemName</label>
    <input type="text" class="form-control" id="ItemName" runat="server" placeholder="ItemName">

  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">ItemCategory</label>
    <input type="text" class="form-control" id="ItemCategory" runat="server" placeholder="ItemCategory">
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">ItemTopic</label>
    <input type="text" class="form-control" id="ItemTopic" runat="server" placeholder="ItemTopic">
  </div>
  <div class="form-group">
    <label for="exampleInputFile">File input</label>
   
  
   
   
      <asp:FileUpload ID="uploadfile" runat="server" />
  
  </div>
  
    <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Upload" />
  






    
   
    </form>
</body>
</html>
