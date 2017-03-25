using UnityEngine;
using System.Collections;

public class Equip : AbstractBehavior {

	private int _currentItem = 0;
	private Animator animatior;

	public int currentItem{
		get { return _currentItem; }
		set{
			_currentItem = value;
			animatior.SetInteger ("EquippedItem", _currentItem);
		}
	}

	override protected void Awake(){
		base.Awake ();
		animatior = GetComponent<Animator> ();
	}
}
