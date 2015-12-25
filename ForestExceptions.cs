using System;

namespace Forest
{
	class ForestExceptions
	{
		public class ForestException : Exception
		{
			public override string Message
			{
				get { return "unknown forest exception"; }
			}
		}

		public class OutOfMapBounds : ForestException
		{
			public override string Message
			{
				get { return "it's not on the map"; }
			}
		}

		public class NoCreatureWithThisName : ForestException
		{
			public override string Message
			{
				get { return "move creature on the map."; }
			}
		}

		public class InavalidMoveVector : ForestException
		{
			public override string Message
			{
				get { return "vector is Invalid. "; }
			}
		}
	}

}
