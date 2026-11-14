extends CSGBox3D

@export var friction := INF
@export var axis := 0
@export var spin_speed := 1.0

func _process(delta: float) -> void:
	match axis:
		0:
			rotation.x += spin_speed * delta
		1:
			rotation.y += spin_speed * delta
		2:
			rotation.z += spin_speed * delta
