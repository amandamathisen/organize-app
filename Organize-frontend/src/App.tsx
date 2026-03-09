import { useEffect, useState } from "react";
import {
  getTodos,
  createTodo,
  updateTodo,
  deleteTodo,
  type Todo,
} from "./api/todos";
import "./App.css";

function App() {
  const [todos, setTodos] = useState<Todo[]>([]);
  const [newTitle, setNewTitle] = useState("");

  useEffect(() => {
    load();
  }, []);

  async function load() {
    const items = await getTodos();
    setTodos(items);
  }

  async function add() {
    if (!newTitle.trim()) return;
    await createTodo(newTitle.trim());
    setNewTitle("");
    load();
  }

  async function toggle(t: Todo) {
    await updateTodo({ ...t, isCompleted: !t.isCompleted });
    load();
  }

  async function remove(id: number) {
    await deleteTodo(id);
    load();
  }

  return (
    <div className="App">
      <h1>My todos</h1>

      <div>
        <input
          value={newTitle}
          onChange={(e) => setNewTitle(e.target.value)}
          placeholder="Add todo…"
        />
        <button onClick={add}>Add</button>
      </div>

      <ul>
        {todos.map((t) => (
          <li key={t.id}>
            <label>
              <input
                type="checkbox"
                checked={t.isCompleted}
                onChange={() => toggle(t)}
              />
              {t.title}
            </label>
            <button onClick={() => remove(t.id)}>✕</button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
