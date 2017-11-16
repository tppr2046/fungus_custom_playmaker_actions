// (c) Copyright aaaaa
// This action is just a very simple function to call a Fungus flowchart block.

using UnityEngine;
using Fungus;

namespace HutongGames.PlayMaker.Actions {
	[ActionCategory("Fungus")]
	[Tooltip("Get boolean variable from a Fungus Block")]
	public class FungusGetBoolean : FsmStateAction {
		[RequiredField]
		[Tooltip("Using a Fungus flowchart")]
		public Flowchart flowchart;

		[RequiredField]
		[Tooltip("Enter the variable name in Fungus block")]
		public FsmString parameter;

		[ActionSection("Results")]

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Save as FSM variable")]
		public FsmBool result;


		public override void Reset() {
			base.Reset ();
			flowchart = null;
			parameter = null;
			result = null;
		}


		public override void OnEnter() {

			result.Value = flowchart.GetBooleanVariable (parameter.Value);
			Finish ();
			}


	}
}