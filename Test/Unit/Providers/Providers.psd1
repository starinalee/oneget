﻿@{
	RootModule = 'testproviders.psm1'
	ModuleVersion = '0.1'
	GUID = '12312312-4a6c-43c5-ba3f-619b18bbb123'
	Author = 'Microsoft Corporation'
	CompanyName = 'Microsoft Corporation'
	Copyright = '© Microsoft Corporation. All rights reserved.'
	PowerShellVersion = '3.0'
	VariablesToExport = "*"
	PrivateData = @{ 
		"PackageManagementProviders" = @(
			'TestPackageProvider.psm1', 
			'PSChained1Provider.psm1' 
		)
	}
}

