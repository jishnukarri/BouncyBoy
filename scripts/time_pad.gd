extends CSGBox3D

@export var friction := 1.0
@onready var collision: CollisionShape3D = $area/collision

var timer := 0.0
var started = 0

func on_off() -> void:
	started = 1 - started

func _on_area_body_entered(body: Node3D) -> void:
	if body.is_in_group("player"):
		on_off()

func _ready() -> void:
	collision.shape.size = self.size

func _process(delta: float) -> void:
	if started == 1:
		timer += delta
		global.timer = timer
