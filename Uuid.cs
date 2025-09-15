using System;
public class Uuid
{
	public static string GenerateUUIDv4()
		{
			return Guid.NewGuid().ToString();
		}



}

