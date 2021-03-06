using System;
using PubNub_Messaging;
using NUnit.Framework;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading;


namespace PubNubTest
{
	[TestFixture]
	public class WhenGetRequestServerTime
	{
		[Test]
		public void ThenItShouldReturnTimeStamp()
		{
			Pubnub pubnub = new Pubnub(
				"demo",
				"demo",
				"",
				"",
				false
				);
			
			PubnubUnitTest unitTest = new PubnubUnitTest();
			unitTest.TestClassName = "WhenGetRequestServerTime";
			unitTest.TestCaseName = "ThenItShouldReturnTimeStamp";
			
			pubnub.PubnubUnitTest = unitTest;
			
			string strResponse = "";
			Common cm = new Common();
			cm.deliveryStatus = false;
			cm.objResponse = null;
			
			pubnub.time(cm.DisplayReturnMessage);
			//cm.objResponse = null;
			while (!cm.deliveryStatus) ;
			
			IList<object> fields = cm.objResponse as IList<object>;
			strResponse = fields[0].ToString();
			Console.WriteLine("Resp:" + strResponse);
			Assert.AreNotEqual("0",strResponse);
		}
		
	}
}

