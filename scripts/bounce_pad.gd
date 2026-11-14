extends CSGBox3D

@export var friction := 1.0
@export var strength := 10.0

func _on_area_body_entered(body: Node3D) -> void:
	if body.is_in_group("player"):
		body.velocity = strength
