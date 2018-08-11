using UnityEngine;

public class DragAnchorCharacter : MonoBehaviour
{
	[SerializeField]
	float _movementForceMagnitude = 100f;

	[SerializeField]
	DragAnchor[] _anchors = new DragAnchor[0];

	public void UpdateCharacter()
	{
		foreach(DragAnchor anchor in _anchors)
		{
			anchor.UpdateAnchor(_movementForceMagnitude);
		}
	}
}