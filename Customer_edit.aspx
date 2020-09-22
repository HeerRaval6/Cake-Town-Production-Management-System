<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Customer_edit.aspx.cs" Inherits="production_management.Customer_edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">
  <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title"> Customer Edit </h5>
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Name
                                        </label>
                                        <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Name of Customer" />
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Phone
                                        </label>
                                        <asp:TextBox ID="txtPhone" runat="server" class="form-control" placeholder="Phone Number" />
                                    </div>
                                </div>


                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Email
                                        </label>
                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" placeholder="Email" />
                                    </div>
                                </div>
                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Address
                                        </label>
                                        <asp:TextBox ID="txtAddress" runat="server" Class="form-control" placeholder="address" TextMode="MultiLine" /> 
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Fax Number
                                        </label>
                                        <asp:TextBox ID="txtFax" runat="server" class="form-control" placeholder="Fax Number"  />
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        City
                                        </label>
                                        <asp:TextBox ID="txtCity" runat="server" class="form-control" placeholder="City" />
                                    </div>
                                </div>
                                
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        State
                                        </label>
                                        <asp:TextBox ID="txtState" runat="server" Class="form-control" placeholder="State"  /> 
                                    </div>
                                </div>

                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>
                                        Pin Code
                                        </label>
                                        <asp:TextBox ID="txtPin" runat="server" class="form-control" placeholder="Pin Code"  />
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
