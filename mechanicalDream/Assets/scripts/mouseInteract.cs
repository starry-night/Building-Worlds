using UnityEngine;
using System.Collections;

public class mouseInteract : MonoBehaviour {

	private Vector3 screenPoint;	
	private Vector3 offset;
	
	public Texture2D altCursor;

	public Texture2D p1;
	public Texture2D p2;

	private bool ptoggle=true;

	private bool wtoggle=true;

	public Texture2D w1;
	public Texture2D w2;

	void OnMouseEnter () {
		Cursor.SetCursor(altCursor, Vector2.zero, CursorMode.Auto);
	}
	
	void OnMouseExit () {
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);	
	}
	
	void OnMouseDown()
	{
		if (this.gameObject.tag == "screen") {
		this.gameObject.renderer.enabled = !renderer.enabled;
		}
		if (this.gameObject.tag == "light") {
		this.gameObject.light.enabled = !light.enabled;
		}
		if (this.gameObject.tag == "painting") {
			if (ptoggle==true){
				this.gameObject.renderer.material.mainTexture= p2;
				ptoggle=false;
			}
			else{
				this.gameObject.renderer.material.mainTexture=p1;
				ptoggle=true;
			}
		}
		if (this.gameObject.tag == "window") {
			if (wtoggle==true){
				this.gameObject.renderer.material.mainTexture= w2;
				wtoggle=false;
			}
			else{
				this.gameObject.renderer.material.mainTexture=w1;
				wtoggle=true;
			}
		}
	}
	

}
