<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="dispatch_material.aspx.cs" Inherits="production_management.dispatch_material" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">

     <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title"> Dispatch Material
            
                        </h5>
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <table>
                                        <tr>
                                            <td>
                                                Production Qty :
                                                <asp:TextBox ID="txtqty" runat="server" />
                                                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="table">
                                        <thead class="text-primary">
                                            <tr>
                                            <td>Name</td>
                                            <td>Type</td>
                                            <td>Stock</td>
                                            <td>Required Qty </td>
                                            
                                            </tr>
                                        </thead>
                                        <tbody>

                                            <asp:Repeater ID="rpt" runat="server">
                                                <ItemTemplate>

                                            <tr>
                                            <td><%#Eval("name") %></td>
                                            <td><%#Eval("type_raw") %></td> 
                                            <td><%#Eval("stock") %></td> 
                                            <td><%#Eval("req_qty") %></td> 
                                            </tr>

                                                </ItemTemplate>
                                                    
                                            </asp:Repeater>
                                          
                                        </tbody>
                                    </table>

                                   
                                </div>
                                <asp:Button ID="btndispatch" runat="server" Text="Dispatch" OnClick="btndispatch_Click" />
                            </div>
                           
                        </form>
                    </div>
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
