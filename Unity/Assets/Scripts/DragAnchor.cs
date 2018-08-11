using UnityEngine;

public class DragAnchor : MonoBehaviour
{
	[SerializeField]
	Rigidbody2D _body;

	[SerializeField]
	PolygonCollider2D _collider;

	bool _isBeingDragged;

	void OnMouseDown()
	{
		_isBeingDragged = true;
	}

	void OnMouseUp()
	{
		_isBeingDragged = false;
	}

	public void UpdateAnchor(float movementForceMagnitude)
	{
		if(_isBeingDragged)
		{
			Vector3 movementOrigin = _collider.bounds.center;
			Vector3 movementDirection = Vector3.Normalize(Camera.main.ScreenToWorldPoint(Input.mousePosition) - movementOrigin);
			movementDirection.z = 0f;
			
			Debug.LogFormat("{0} is being dragged. Center {1} Direction {2}", name, movementOrigin, movementDirection);

			_body.AddForceAtPosition(movementDirection * movementForceMagnitude, movementOrigin);
		}
	}
}