<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="purchaseadd.aspx.cs" Inherits="production_management.purchaseadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title"> Purhcase Add </h5>
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Quantity
                                        </label>
                                        <asp:TextBox ID="txtQty" runat="server" class="form-control" placeholder="quantity" />
                                    </div>
                                </div>


                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        raw
                                        </label>

                                         <asp:DropDownList ID ="txtRaw" runat="server" ForeColor="Black" class="form-control" >
                                            <asp:ListItem Value="1" Text="abc"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="xyz"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="pqr"></asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                </div>
                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        vendor
                                        </label>
                                         <asp:DropDownList ID ="txtVendor" runat="server" ForeColor="Black" class="form-control" >
                                            <asp:ListItem Value="1" Text="abc"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="xyz"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="pqr"></asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Purchase Date
                                        </label>
                                        <asp:TextBox ID="txtDate" runat="server" class="form-control" placeholder="date"  TextMode="Date" />
                                    </div>
                                </div>
                                
                            </div>
                        
                    </div>

                         <div class="card-footer">
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click"  class="btn btn-fill btn-primary" />
                           
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
