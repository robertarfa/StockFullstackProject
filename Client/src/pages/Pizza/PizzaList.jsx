// /* eslint-disable react/prop-types */
// import {
//   Box,
//   Button,
//   IconButton,
//   List,
//   ListItem,
//   ListItemText,
//   TextField,
// } from "@mui/material";
// import EditIcon from "@mui/icons-material/Edit";
// import DeleteIcon from "@mui/icons-material/Delete";
// import React, { useState } from "react";

// export default function PizzaList({
//   name,
//   data,
//   onCreate,
//   onUpdate,
//   onDelete,
//   error,
// }) {
//   const [formData, setFormData] = useState({
//     id: "",
//     name: "",
//     description: "",
//   });
//   const [editingId, setEditingId] = useState(null);

//   const handleFormChange = (event) => {
//     const { name, value } = event.target;

//     setFormData((prev) => ({
//       ...prev,
//       [name]: value,
//     }));
//   };

//   const handleSubmit = (event) => {
//     event.preventDefault();

//     if (editingId) {
//       onUpdate(formData);
//       setEditingId(null);
//     } else {
//       onCreate(formData);
//     }

//     setFormData({ id: "", name: "", description: "" });
//   };

//   const handleEdit = (item) => {
//     console.log(item);
//     setEditingId(item.id);

//     setFormData({
//       id: item.id,
//       name: item.name,
//       description: item.description,
//     });
//   };

//   const handleCancelEdit = () => {
//     setEditingId(null);
//     setFormData({ id: "", name: "", description: "" });
//   };

//   return (
//     <Box
//       className="Box"
//       sx={{ display: "flex", flexDirection: "column", alignItems: "center" }}
//     >
//       <h2>{name}</h2>
//       <form
//         onSubmit={handleSubmit}
//         style={{
//           display: "flex",
//           flexDirection: "row",
//           alignItems: "center",
//           gap: 8,
//         }}
//       >
//         <TextField
//           label="Name"
//           name="name"
//           value={formData.name}
//           onChange={handleFormChange}
//         />
//         <TextField
//           label="Description"
//           name="description"
//           value={formData.description}
//           onChange={handleFormChange}
//         />
//         <Button sx={{ mr: 1 }} variant="contained" type="submit">
//           {editingId === null ? "Create" : "Update"}
//         </Button>
//         {editingId !== null && (
//           <Button
//             variant="contained"
//             color="secondary"
//             onClick={handleCancelEdit}
//           >
//             Cancel
//           </Button>
//         )}
//       </form>

//       <List sx={{ width: "100%", maxWidth: 360 }}>
//         {data.map((item) => (
//           <ListItem
//             key={item.id}
//             secondaryAction={
//               <>
//                 <IconButton
//                   edge="end"
//                   aria-label="edit"
//                   onClick={() => handleEdit(item)}
//                 >
//                   <EditIcon />
//                 </IconButton>
//                 <IconButton
//                   edge="end"
//                   aria-label="delete"
//                   onClick={() => onDelete(item.id)}
//                 >
//                   <DeleteIcon />
//                 </IconButton>
//               </>
//             }
//           >
//             <ListItemText primary={item.name} secondary={item.description} />
//           </ListItem>
//         ))}
//       </List>
//       {/* {error && <p>{error}</p>} */}
//     </Box>
//   );
// }
