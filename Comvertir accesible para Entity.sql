use dbtecnotiv;
set global optimizer_switch='derived_merge=off';
set optimizer_switch='derived_merge=off';

select @@optimizer_switch;
select @@GLOBAL.optimizer_switch; 