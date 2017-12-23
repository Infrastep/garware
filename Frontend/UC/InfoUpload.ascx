<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InfoUpload.ascx.cs" Inherits="Frontend.UC.InfoUpload" %>
<input id="CID" type="hidden" value="0" />
<div class="line4"></div>
Upload File<br />
<input type="file" class="form-control " id="Certificate" />
<br />
Description<br />
<input type="text" class="form-control " placeholder="" id="Description" />
<br />
Valid Upto<br />
<input type="text" class="form-control " placeholder="MM/YY" id="Validity" />
<br />
<br />

<button type="button" class="btn-search5" id="InsertdataCC">Save changes</button>
