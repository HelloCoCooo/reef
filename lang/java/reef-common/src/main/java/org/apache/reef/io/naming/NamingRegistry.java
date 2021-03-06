/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
package org.apache.reef.io.naming;

import org.apache.reef.wake.Identifier;

import java.net.InetSocketAddress;

/**
 * Allows to register and unregister addresses for Identifiers.
 */
public interface NamingRegistry {

  /**
   * Register the given Address for the given Identifier.
   *
   * @param id
   * @param addr
   * @throws Exception
   */
  void register(final Identifier id, final InetSocketAddress addr) throws Exception;

  /**
   * Unregister the given Identifier from the registry.
   *
   * @param id
   * @throws Exception
   */
  void unregister(final Identifier id) throws Exception;
}
