// MongoDB Assignment (Reshmitha Kandagatla)


use TestDb

db.createCollection('images')
db.createCollection('students')

db.images.find({})
db.students.find({})


// -------------------- 1 --------------------

db.images.find({ext:{$eq:'png'}}).count()



// -------------------- 2 --------------------

db.images.aggregate([
 { $match:{quality:{$eq:'M'}} },
 { $group:{ _id:0 , totalSales:{$sum:"$price"} } }
])



// -------------------- 3 --------------------

db.images.aggregate([
 { $group:{ _id:'$ext', totalSales:{$sum:"$price"} } }
])



// -------------------- 4 --------------------

db.images.aggregate([
 { $match:{quality:{$eq:'L'}} },
 { $group:{ _id:0 , pricee:{$min:"$price"} } },
 { $project:{_id:0,price:'$pricee'} }
])



// -------------------- 5 --------------------

db.images.aggregate([
 { $group:{ _id:'$ext', totalImages:{$sum:1} } }
])



// -------------------- 6 --------------------

db.images.aggregate([
 {$sort:{price:-1}},
 {$project:{_id:0,name:'$name',ext:'$ext',quality:'$quality',price:'$price'}}
])



// -------------------- 7 --------------------

db.images.find({
 $or:[
  {category:{$eq:'cars'}},
  {category:{$eq:'birds'}}
 ]
}).project({_id:0,name:1})



// -------------------- 8 --------------------

db.images.aggregate([
 { $group:{ _id:'$category', totalSales:{$sum:"$price"} } },
 { $match:{totalSales:{$gt:10000}} }
])



// -------------------- 9 --------------------

db.students.find({name:{$eq:'Mahesh'}})
 .project({_id:0,month:{$month:"$dob"}})



// -------------------- 10 --------------------

db.students.find({name:{$eq:'Anand'}})
 .project({_id:0,month:{$year:"$dob"}})



// -------------------- 11 --------------------

db.students.find({
 $or:[
  {name:{$eq:'Gita'}},
  {name:{$eq:'Mahesh'}}
 ]
}).project({_id:0,email:1})



// -------------------- 12 --------------------

db.students.aggregate([
 {$unwind:"$courses"},
 {$group:{ _id:"$name", totfee:{$sum:"$courses.fee"} }},
 {$match:{totfee:{$gt:50000}}}
])



// -------------------- 13 --------------------

db.students.aggregate([
 {$unwind:"$courses"},
 {$match:{$or:[{name:{$eq:'Suresh'}},{name:{$eq:'Anand'}}]}},
 {$group:{_id:"$courses.name"}}
])



// -------------------- 14 --------------------

db.students.aggregate([
 {$unwind:"$courses"},
 {$match:{"courses.name":{$eq:"Painting"}}},
 {$project:{_id:0,name:'$name'}}
])



// -------------------- 15 --------------------

db.students.aggregate([
 {$unwind:"$courses"},
 {$group:{ _id:"$name", totfee:{$sum:"$courses.fee"} }}
])