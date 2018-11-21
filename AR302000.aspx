...
    <px:PXSmartPanel runat="server" ID="CstSmartPanel3" Key="MyPanel" Caption="MI PANEL DE OPCIONES" CaptionVisible ="true" AutoCallBack-Command="Refresh" DesignView="Content">
		<px:PXFormView ID="frmMyCommand" runat="server" SkinID="Transparent" DataMember="MyPanel"	DataSourceID="ds" EmailingGraph="" TabIndex="400">
			<Template>
			<px:PXLayoutRule runat="server" ControlSize="M" LabelsWidth="M" StartColumn="True" />
				<px:PXLabel ID="lblWarning" runat="server" AlreadyLocalized="False">
					SMART PANEL DE OPCIONES
				</px:PXLabel>
                <px:PXCheckBox ID="edIsPago" runat="server" AlreadyLocalized="False" DataField="IsPago" Text="Es pago" Size="M">
				</px:PXCheckBox>
                <px:PXDateTimeEdit ID="edFecha" runat="server" AlreadyLocalized="False" DataField="Fecha">
				</px:PXDateTimeEdit>
                    <px:PXPanel ID="PXPanel1" runat="server" SkinID="Buttons">
					<px:PXButton ID="btnMyCommandOK" runat="server" AlreadyLocalized="False" DialogResult="OK" Text="OK">
						<AutoCallBack Command="Save" Target="frmMyCommand" />
					</px:PXButton>
					<px:PXButton ID="btnMyCommandCancel" runat="server" AlreadyLocalized="False" DialogResult="Cancel" Text="Cancel" />
				</px:PXPanel>
			</Template>
		</px:PXFormView>
		</px:PXSmartPanel>
...
