<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="raw_add.aspx.cs" Inherits="production_management.raw_add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">
 <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title"> Raw Material add </h5>
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Name
                                        </label>
                                        <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Name of Raw Material" />
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Type of Raw Material
                                        </label>
                                      <asp:DropDownList ID="txtRawtype" runat="server" ForeColor="Black" class="form-control">
                                        <asp:ListItem Text="Dairy Products"></asp:ListItem>
                                        <asp:ListItem Text="Powder Products"></asp:ListItem>
                                        <asp:ListItem Text="Essense"></asp:ListItem>
                                        <asp:ListItem Text="Fruits"></asp:ListItem>
                                    </asp:DropDownList>
                                    
                                    </div>
                                </div>


                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        stock
                                        </label>
                                        <asp:TextBox ID="txtStock" runat="server" class="form-control" placeholder="stock" />
                                    </div>
                                </div>
                                
                            </div>
                        
                    </div>

                         <div class="card-footer">
                        <asp:Button ID="btn" runat="server" Text="Submit" OnClick="btnsubmit_Click"  class="btn btn-fill btn-primary" />
                           
                    </div>
                     <div class="card-footer">
                        <asp:Label ID="lblmsg" runat="server" ForeColor="White"  />
                    </div>
                    </form>

                    
                </div>
            </div>
            <div class="col-md-4">
                <div class="card  card-user">
                    <div class="card-body ">
                        <p class="card-text">
                        <div class="author">
                            <div class="block block-one">
                            </div>
                            <div class="block block-two">
                            </div>
                            <div class="block block-three">
                            </div>
                            <div class="block block-four">
                            </div>
                            <a href="#">
                            <img class="avatar" src="../assets/img/anime6.png" alt="...">
                            <h5 class="title">Mike Andrew</h5>
                            </a>&nbsp;<p class="description">
                                Ceo/Co-Founder
                            </p>
                        </div>
                        </p>
                        <p class="card-description">
                            Do not be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
                        </p>
                    </div>
                    <div class="card-footer ">
                        <div class="button-container">
                            <button href="#" class="btn btn-icon btn-round btn-facebook">
                                <i class="fab fa-facebook"></i>
                            </button>
                            <button href="#" class="btn btn-icon btn-round btn-twitter">
                                <i class="fab fa-twitter"></i>
                            </button>
                            <button href="#" class="btn btn-icon btn-round btn-google">
                                <i class="fab fa-google-plus"></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
