/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeJobResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string name;

		private string failAct;

		private string type;

		private int? maxRetry;

		private int? retryInterval;

		private string runParameter;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string FailAct
		{
			get
			{
				return failAct;
			}
			set	
			{
				failAct = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public int? MaxRetry
		{
			get
			{
				return maxRetry;
			}
			set	
			{
				maxRetry = value;
			}
		}

		public int? RetryInterval
		{
			get
			{
				return retryInterval;
			}
			set	
			{
				retryInterval = value;
			}
		}

		public string RunParameter
		{
			get
			{
				return runParameter;
			}
			set	
			{
				runParameter = value;
			}
		}
	}
}
