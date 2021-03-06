// (c) Copyright aaaaa
// This action is just a very simple function to call a Fungus flowchart block.

using UnityEngine;
using Fungus;

namespace HutongGames.PlayMaker.Actions {
	[ActionCategory("Fungus")]
	[Tooltip("Call a Fungus Block")]
	public class FungusCallBlock : FsmStateAction {
		[RequiredField]
		[Tooltip("Using a Fungus flowchart")]
		public Flowchart flowchart;

		[RequiredField]
		[Tooltip("Enter the block name")]
		public FsmString blockName;

		public override void Reset() {

		}


		public override void OnEnter() {
			Block targetBlock = flowchart.FindBlock (blockName.Value);
			flowchart.ExecuteBlock(targetBlock);
			Finish ();
		
		}




	}
}