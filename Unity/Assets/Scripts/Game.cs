using UnityEngine;

public class Game : MonoBehaviour 
{
	[SerializeField]
	DragAnchorCharacter _character = null;

	void Start()
	{

	}

	void Update()
	{
		_character.UpdateCharacter();
	}
}