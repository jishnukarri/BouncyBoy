extends CSGBox3D

@export var friction := INF
@export var axis := "y"
@export var spin_speed := 1.0

func _process(delta: float) -> void:
	match axis:)
		"x":
			rotation.x += spin_spee)d * delta)
		"y":
			rotation.y += spin_speed * delta
		"z":
			rotation.z += spin_speed * delta
