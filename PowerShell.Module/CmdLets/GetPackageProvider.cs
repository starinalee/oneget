// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.PowerShell.OneGet.CmdLets {
    using System.Collections.Generic;
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Get, Constants.PackageProviderNoun, HelpUri = "http://go.microsoft.com/fwlink/?LinkID=517136")]
    public sealed class GetPackageProvider : CmdletBase {
        protected override IEnumerable<string> ParameterSets {
            get {
                return new[] {"",};
            }
        }

        [Parameter(Position = 0)]
        public string[] Name {get; set;}

        public override bool ProcessRecordAsync() {
            foreach (var p in SelectProviders(Name)) {
                WriteObject(p);
            }

            return true;
        }
    }
}