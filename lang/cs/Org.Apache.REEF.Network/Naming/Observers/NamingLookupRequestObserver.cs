﻿// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System.Collections.Generic;
using Org.Apache.REEF.Common.Io;
using Org.Apache.REEF.Network.Naming.Events;
using Org.Apache.REEF.Wake.RX;

namespace Org.Apache.REEF.Network.Naming.Observers
{
    /// <summary>
    /// Handler for looking up IPEndpoints registered with the NameServer
    /// </summary>
    internal sealed class NamingLookupRequestObserver : AbstractObserver<NamingLookupRequest>
    {
        private readonly NameServer _server;

        public NamingLookupRequestObserver(NameServer server)
        {
            _server = server;
        }

        /// <summary>
        /// Look up the IPEndpoints for the given identifiers and write them
        /// back to the NameClient
        /// </summary>
        /// <param name="value">The lookup request event</param>
        public override void OnNext(NamingLookupRequest value)
        {
            List<NameAssignment> assignments = _server.Lookup(value.Identifiers);
            value.Link.Write(new NamingLookupResponse(assignments));
        }
    }
}
