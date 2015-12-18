using System;

namespace FastSms.Exceptions {
	/// <summary>
	///    API Exception.
	/// </summary>
	public class FastSmsException : Exception {
		public FastSmsException () {
		}

	    public FastSmsException ( string errorCode ) {
			Code = errorCode;
	        var error = FastSmsErrors.Errors.ContainsKey(errorCode) ? FastSmsErrors.Errors[errorCode] : null;
			Message = error ?? "N/A";
		}

		public string Code { get; set; }
		public new string Message { get; set; }
	}
}