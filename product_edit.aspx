<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="product_edit.aspx.cs" Inherits="production_management.product_edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">

    
     <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title">Product Edit </h5>
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Product Name
                                        </label>
                                        <asp:TextBox id="txtName" runat="server" class="form-control" placeholder="Product Name" />
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Product Size
                                        </label>
                                        <asp:DropDownList ID="txtSize"  runat="server" ForeColor="Black" class="form-control">
                                        <asp:ListItem Text="100gm"></asp:ListItem>
                                        <asp:ListItem Text="250gm"></asp:ListItem>
                                        <asp:ListItem Text="500gm"></asp:ListItem>
                                        <asp:ListItem Text="750gm"></asp:ListItem>
                                        <asp:ListItem Text="1kg"></asp:ListItem>
                                        <asp:ListItem Text="2kg"></asp:ListItem>
                                        <asp:ListItem Text="3kg"></asp:ListItem>
                                        <asp:ListItem Text="4kg"></asp:ListItem>
                                        <asp:ListItem Text="5kg"></asp:ListItem>
                                    </asp:DropDownList>
                                    </div>
                                </div>


                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Product Flavour
                                        </label>
                                        <asp:DropDownList ID="txtFlavour"  runat="server" ForeColor="Black" class="form-control">
                                        <asp:ListItem Text="chocolate"></asp:ListItem>
                                        <asp:ListItem Text="orange"></asp:ListItem>
                                        <asp:ListItem Text="stawberry"></asp:ListItem>
                                        <asp:ListItem Text="black forest"></asp:ListItem>
                                        <asp:ListItem Text="blue berry"></asp:ListItem>
                                        <asp:ListItem Text="red velvet"></asp:ListItem>
                                        <asp:ListItem Text="jelly fills"></asp:ListItem>
                                        <asp:ListItem Text="vanilla"></asp:ListItem>
                                        <asp:ListItem Text="pineapple"></asp:ListItem>
                                    </asp:DropDownList>
                                    </div>
                                </div>
                                
                            </div>
                        
                    </div>
                    <div class="card-footer">
                       <asp:Button ID="btn1" runat="server" Text="Submit"  OnClick="btnsubmit_Click" Class="btn btn-fill btn-primary" />
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
