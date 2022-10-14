using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdGridScript : GridScript
{
    string[] gridString = new string[]{
		"lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll|",
		"lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll|",
		"pppppplpppplppppppppppppppppppppfpfpppppppprrrrrrrrrrrrrrrppfprppprrpppppfwpppppwpppppp|",
		"pppplppppplwppppppppplpppppppfpppffppfpppppppprrppppprprrrrpfprpprrrpppfwwpwpwfpppppppp|",
		"pppllplppppwpwpfppppplpwwpppffppppppffpppppfrrrppppprrpwrrrprrfpllrprrfpffwppfwpwpppppp|",
		"pppplpppppplpppplpffppppppppppffwwwwwwwwppppfpppffpfprpwwrpprrppllpffpppppwpwwppppppppp|",
		"pppplpppppplpppplpppppppwppppppfwffffffwffpfppprfpprppprrprppfpppllrpppfpwfpppppppppppp|",
		"pppplplppppwpppplpppppppwpppppppwffffffwppfppppfpprrppppprpprprppwlwrppfpwppppppppppppp|",
		"pppppplppppwpppplfpppppppppppppwwppppppwppppfpprppprppprppppppprrllppwwwppfpppppppppppp|",
		"pppplplppwplpppppfpppppffpppppwffffffffwpppwwppwwppprfpppffppppppllppppfpwfpppppppppppp|",
		"pppllpppppwlppppppppppppfppppppwfffffffwppppfpppwrpppfrrpppppprllpppppppppppppppppppppp|",
		"pppplpppppwpppppppppfpppwpppppppwwwwwwwppppppprpwpppprrppppppllppppfwwpfppfpppppwpppppp|",
		"pppppppppppwpppplpppppppwppppwppfffppppppfpwwfrppprrpfprpppwrrpppffppfppppwwppwwwpppppp|",
		"pppllppwppplwppplpppppppppwpwwpfffpppppfppppprrprrffppppppwwrrppppwfffppppwpppppwpppppp|",
		"pppplpppppplpppplfppppppppwpwpppfppppppprrrrrpppppppffprrppwprppwpwpppppfpwpppppwpppppp|",
		"lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll|",
		"lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll|"
	};

	// Use this for initialization
	void Start () {
		gridWidth = gridString[0].Length;
		gridHeight = gridString.Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override float GetMovementCost(GameObject go){
		return base.GetMovementCost(go);
	}
	
	protected override Material GetMaterial(int x, int y){

		char c = gridString[y].ToCharArray()[x];

		Material mat;

		switch(c){
		case 'r': 
			mat = mats[1];
			break;
		case 'w': 
			mat = mats[2];
			break;
		case 'l': 
			mat = mats[3];
			break;
		case 'p': 
			mat = mats[4];
			break;
		case 'f': 
			mat = mats[5];
			break;
		default: 
			mat = mats[0];
			break;
		}
	
		return mat;
	}
}
