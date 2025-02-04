// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
using System;
 using AWS.Cryptography.KeyStore; namespace AWS.Cryptography.KeyStore {
 public class BeaconKeyMaterials {
 private string _beaconKeyIdentifier ;
 private System.Collections.Generic.Dictionary<string, string> _encryptionContext ;
 private System.IO.MemoryStream _beaconKey ;
 private System.Collections.Generic.Dictionary<string, System.IO.MemoryStream> _hmacKeys ;
 public string BeaconKeyIdentifier {
 get { return this._beaconKeyIdentifier; }
 set { this._beaconKeyIdentifier = value; }
}
 public bool IsSetBeaconKeyIdentifier () {
 return this._beaconKeyIdentifier != null;
}
 public System.Collections.Generic.Dictionary<string, string> EncryptionContext {
 get { return this._encryptionContext; }
 set { this._encryptionContext = value; }
}
 public bool IsSetEncryptionContext () {
 return this._encryptionContext != null;
}
 public System.IO.MemoryStream BeaconKey {
 get { return this._beaconKey; }
 set { this._beaconKey = value; }
}
 public bool IsSetBeaconKey () {
 return this._beaconKey != null;
}
 public System.Collections.Generic.Dictionary<string, System.IO.MemoryStream> HmacKeys {
 get { return this._hmacKeys; }
 set { this._hmacKeys = value; }
}
 public bool IsSetHmacKeys () {
 return this._hmacKeys != null;
}
 public void Validate() {
 if (!IsSetBeaconKeyIdentifier()) throw new System.ArgumentException("Missing value for required property 'BeaconKeyIdentifier'");
 if (!IsSetEncryptionContext()) throw new System.ArgumentException("Missing value for required property 'EncryptionContext'");

}
}
}
