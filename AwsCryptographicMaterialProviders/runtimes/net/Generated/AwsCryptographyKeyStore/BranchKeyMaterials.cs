// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
using System;
 using AWS.Cryptography.KeyStore; namespace AWS.Cryptography.KeyStore {
 public class BranchKeyMaterials {
 private string _branchKeyIdentifier ;
 private string _branchKeyVersion ;
 private System.Collections.Generic.Dictionary<string, string> _encryptionContext ;
 private System.IO.MemoryStream _branchKey ;
 public string BranchKeyIdentifier {
 get { return this._branchKeyIdentifier; }
 set { this._branchKeyIdentifier = value; }
}
 public bool IsSetBranchKeyIdentifier () {
 return this._branchKeyIdentifier != null;
}
 public string BranchKeyVersion {
 get { return this._branchKeyVersion; }
 set { this._branchKeyVersion = value; }
}
 public bool IsSetBranchKeyVersion () {
 return this._branchKeyVersion != null;
}
 public System.Collections.Generic.Dictionary<string, string> EncryptionContext {
 get { return this._encryptionContext; }
 set { this._encryptionContext = value; }
}
 public bool IsSetEncryptionContext () {
 return this._encryptionContext != null;
}
 public System.IO.MemoryStream BranchKey {
 get { return this._branchKey; }
 set { this._branchKey = value; }
}
 public bool IsSetBranchKey () {
 return this._branchKey != null;
}
 public void Validate() {
 if (!IsSetBranchKeyIdentifier()) throw new System.ArgumentException("Missing value for required property 'BranchKeyIdentifier'");
 if (!IsSetBranchKeyVersion()) throw new System.ArgumentException("Missing value for required property 'BranchKeyVersion'");
 if (!IsSetEncryptionContext()) throw new System.ArgumentException("Missing value for required property 'EncryptionContext'");
 if (!IsSetBranchKey()) throw new System.ArgumentException("Missing value for required property 'BranchKey'");

}
}
}
