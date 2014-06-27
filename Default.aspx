<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel='stylesheet' type="text/css" href='bootstrap.css'/>
<link rel='stylesheet' type="text/css" href='bootstrap-theme.css'/>
    <title></title>
</head>
<body>
<h2 style='margin:auto;width:1200px;'>Content Rating System</h2>

<div style='margin-top:50px;'>
<hr/>
</div>

 <div class="col-md-6 col-md-offset-4">
</div>


<div class="col-xs-12 col-md-12">
<hr/>
</div>

<div class="col-xs-6 col-md-8">


    <form runat="server" class="form-horizontal" role="form">       

<h3 style='color:Blue'>REGISTER HERE</h3>


  <div class="form-group">
    <label for="username" class="col-sm-2 control-label">Username</label>
    <div class="col-sm-4">
      <input type="text" runat="server" class="form-control" id="r_username" placeholder="Username"/>
    </div>
  </div>

  <div class="form-group">
    <label for="name" class="col-sm-2 control-label">Name</label>
    <div class="col-sm-4">
      <input type="text" runat="server" class="form-control" id="r_name" placeholder="First and Last Name"/>
    </div>
  </div>

  <div class="form-group">
    <label for="email" class="col-sm-2 control-label">E-mail</label>
    <div class="col-sm-4">
      <input type="text" runat="server" class="form-control" id="r_email" placeholder="Email-address">
    </div>
  </div>

  <div class="form-group">
    <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
    <div class="col-sm-4">
      <input type="password" runat="server" class="form-control" id="r_password" placeholder="Password">
    </div>
  </div>

  <div class="form-group">
    <label for="inputPassword3" class="col-sm-2 control-label">Re-enter Password</label>
    <div class="col-sm-4">
      <input type="password" runat="server" class="form-control" id="r_password2" placeholder="Re-enter Password">
      <label for="wrongpass" runat="server" visible="false"  id="wp" class="col-sm-12 control-label" style="color:red;">*Passwords do not match</label>
    </div>
  </div>
  
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">

        <asp:Button ID="Button1" CssClass='btn btn-default' runat="server" 
            Text="Register" onclick="Button1_Click1" />
    </div>
  </div>
</form>

</div>



 <div class="col-xs-4 col-md-offset-0">
<img src="fb.png" alt='garvit' class="img-circle"></img>
</div>



   </body>
</html>
