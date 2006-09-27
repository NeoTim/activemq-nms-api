/* * Licensed to the Apache Software Foundation (ASF) under one or more * contributor license agreements.  See the NOTICE file distributed with * this work for additional information regarding copyright ownership. * The ASF licenses this file to You under the Apache License, Version 2.0 * (the "License"); you may not use this file except in compliance with * the License.  You may obtain a copy of the License at * * http://www.apache.org/licenses/LICENSE-2.0 * * Unless required by applicable law or agreed to in writing, software * distributed under the License is distributed on an "AS IS" BASIS, * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. * See the License for the specific language governing permissions and * limitations under the License. *///// NOTE!: This file is autogenerated - do not modify!//        if you need to make a change, please see the Groovy scripts in the//        activemq-core module//using System;using System.Collections;using System.IO;using ActiveMQ.Commands;using ActiveMQ.OpenWire;using ActiveMQ.OpenWire.V2;namespace ActiveMQ.OpenWire.V2{  /// <summary>  ///  Marshalling code for Open Wire Format for DataResponse  /// </summary>  class DataResponseMarshaller : ResponseMarshaller  {    public override DataStructure CreateObject()     {        return new DataResponse();    }    public override byte GetDataStructureType()     {        return DataResponse.ID_DataResponse;    }    //     // Un-marshal an object instance from the data input stream    //     public override void TightUnmarshal(OpenWireFormat wireFormat, Object o, BinaryReader dataIn, BooleanStream bs)     {        base.TightUnmarshal(wireFormat, o, dataIn, bs);        DataResponse info = (DataResponse)o;        info.Data = (DataStructure) TightUnmarshalNestedObject(wireFormat, dataIn, bs);    }    //    // Write the booleans that this object uses to a BooleanStream    //    public override int TightMarshal1(OpenWireFormat wireFormat, Object o, BooleanStream bs) {        DataResponse info = (DataResponse)o;        int rc = base.TightMarshal1(wireFormat, info, bs);        rc += TightMarshalNestedObject1(wireFormat, (DataStructure)info.Data, bs);        return rc + 0;    }    //     // Write a object instance to data output stream    //    public override void TightMarshal2(OpenWireFormat wireFormat, Object o, BinaryWriter dataOut, BooleanStream bs) {        base.TightMarshal2(wireFormat, o, dataOut, bs);        DataResponse info = (DataResponse)o;        TightMarshalNestedObject2(wireFormat, (DataStructure)info.Data, dataOut, bs);    }    //     // Un-marshal an object instance from the data input stream    //     public override void LooseUnmarshal(OpenWireFormat wireFormat, Object o, BinaryReader dataIn)     {        base.LooseUnmarshal(wireFormat, o, dataIn);        DataResponse info = (DataResponse)o;        info.Data = (DataStructure) LooseUnmarshalNestedObject(wireFormat, dataIn);    }    //     // Write a object instance to data output stream    //    public override void LooseMarshal(OpenWireFormat wireFormat, Object o, BinaryWriter dataOut) {        DataResponse info = (DataResponse)o;        base.LooseMarshal(wireFormat, o, dataOut);        LooseMarshalNestedObject(wireFormat, (DataStructure)info.Data, dataOut);    }  }}