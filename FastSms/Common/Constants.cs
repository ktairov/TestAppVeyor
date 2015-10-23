﻿using System.Collections.Generic;

namespace FastSms.Common {
	public static class Constants {
		public static readonly string ApiUrl = "https://my.fastsms.co.uk/api?Token=";

		public static readonly Dictionary<string, string> ErrorList = new Dictionary<string, string> {
			{"-100", "Not Enough Credits"},
			{"-101", "Invalid CreditID"},
			{"-200", "Invalid Contact"},
			{"-300", "General Database Error"},
			{"-301", "Unknown Error"},
			{"-302", "Return XML Error"},
			{"-303", "Received XML Error"},
			{"-400", "Some numbers in list failed"},
			{"-401", "Invalid Destination Address"},
			{"-402", "Invalid Source Address – Alphanumeric too long"},
			{"-403", "Invalid Source Address – Invalid Number"},
			{"-404", "Blank Body"},
			{"-405", "Invalid Validity Period"},
			{"-406", "No Route Available"},
			{"-407", "Invalid Schedule Date"},
			{"-408", "Distribution List is Empty"},
			{"-409", "Group is Empty"},
			{"-410", "Invalid Distribution List"},
			{"-411", "You have exceeded the limit of messages you can send in a single day to a single number"},
			{"-412", "Number is blacklisted"},
			{"-414", "Invalid Group"},
			{"-501", "Unknown Username/Password"},
			{"-502", "Unknown Action"},
			{"-503", "Unknown Message ID"},
			{"-504", "Invalid From Timestamp"},
			{"-505", "Invalid To Timestamp"},
			{"-506", "Source Address Not Allowed (Email2SMS)"},
			{"-507", "Invalid/Missing Details"},
			{"-508", "Error Creating User"},
			{"-509", "Unknown/Invalid User"},
			{"-510", "You cannot set a user’s credits to be less than 0"},
			{"-511", "The system is down for maintenance"},
			{"-512", "User Suspended"},
			{"-513", "License in use"},
			{"-514", "License expired"},
			{"-515", "No License available"},
			{"-516", "Unknown List"},
			{"-517", "Unable to create List"},
			{"-518", "Blank or Invalid Source Address"},
			{"-519", "Blank Message Body"},
			{"-520", "Unknown Group"},
			{"-601", "Unknown Report Type"},
			{"-701", "No UserID Specified"},
			{"-702", "Invalid Amount Specified"},
			{"-703", "Invalid Currency Requested"}
		};
	}
}